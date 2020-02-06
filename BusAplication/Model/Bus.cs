using System.Collections.Generic;
using System.ComponentModel;

public class Bus : INotifyPropertyChanged
{
    private int busId;
    private string name;
    private string kierowca;

    public int BusId
    {
        get
        {
            return busId;
        }
        set
        {
            busId = value;
            OnPropertyChanged("BusId");
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
            OnPropertyChanged("Name");
        }
    }
    public string Kierowca
    {
        get
        {
            return kierowca;
        }
        set
        {
            kierowca = value;
            OnPropertyChanged("Kierowca");
        }
    }
    public List<string> Przystanek { get; set; }

    #region INotifyPropertyChanged Members  

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion

}