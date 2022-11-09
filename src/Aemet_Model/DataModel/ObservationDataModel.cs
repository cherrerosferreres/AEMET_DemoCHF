using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Aemet_Model.Model
{
	public class ObservationDataModel
	{
		/// <summary>
		/// Devuelve los datos de la prediccion o null si no se han obtenido
		/// </summary>
		/// <returns></returns>
		public ObservableCollection<ObservationData> GetObservationData()
		{
			string idema = "2870";
			ObservacionConvencionalApi instance = new ObservacionConvencionalApi();
			var response = instance.DatosDeObservacinTiempoActual1(idema);

			if (response != null)
			{
				//Obtenemos los datos
				Model200 prediccionLeida = (Model200)response;

				// Obtenemos la información descargando el archivo Json de la URL
				System.Net.WebClient myWebClient = new System.Net.WebClient();
				String jsonData = myWebClient.DownloadString(prediccionLeida.Datos);
				List<ObservationData> prediccionList = JsonSerializer.Deserialize<List<ObservationData>>(jsonData);
				ObservableCollection<ObservationData> prediccionDatosOCollection = new ObservableCollection<ObservationData>(prediccionList);
				return prediccionDatosOCollection;
			}
			else
			{
				return null;
			}
		}

	}
}
