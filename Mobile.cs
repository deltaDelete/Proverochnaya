namespace Proverochnaya;
public class Mobile
{
    #region Свойства
    public string Company { 
        get => _company;
        private set { 
            _company = value;
        }
    }
    public string Model { 
        get => _model; 
        private set {
            _model = value;
        }
    }
    public int RAM { 
        get => _ram; 
        private set {
            if (value < 1) return;
            _ram = value;
        }
    }
    public int StorageCapacity { 
        get => _storageCapacity; 
        private set
        {
            if (value < 1) return;
            _storageCapacity = value;
        }
    }
    public int CameraMegaPixels { 
        get => _cameraMegaPixels; 
        private set
        {
            if (value < 1) return;
            _cameraMegaPixels = value;
        }
    }
    #endregion

    #region Поля
    private string _company = string.Empty;
    private string _model = string.Empty;
    private int _ram = 0;
    private int _storageCapacity = 0;
    private int _cameraMegaPixels = 0;
    #endregion

    #region Методы
    public override string ToString()
    {
        return $"{Company} {Model} {StorageCapacity}GB {RAM}GB RAM {CameraMegaPixels}MP";
    }

    public void Start()
    {
        Console.WriteLine($"Запускается телефон: {ToString()}");
    }

    public void Reboot()
    {
        Console.WriteLine($"Перезагружается телефон: {ToString()}");
    }
    #endregion

    #region Конструктор
    public Mobile(string company, string model, int ram, int storage, int cameraMp)
    {
        Company = company;
        Model = model;
        RAM = ram;
        StorageCapacity = storage;
        CameraMegaPixels = cameraMp;
    }
    #endregion
}
