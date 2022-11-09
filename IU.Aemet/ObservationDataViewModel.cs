using Aemet_Model.Model;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace IU.Aemet
{
	public class ObservationDataViewModel : ViewModelBase
	{
		public ObservationDataViewModel()
		{
			ObservationDataModel observation = new ObservationDataModel();
			Source = observation.GetObservationData();
		}
		public ObservableCollection<ObservationData> Source { get; }
	}
}
