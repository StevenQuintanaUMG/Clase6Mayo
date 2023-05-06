namespace carro;

public class Carro
{
    public string Marca { get; set; }
    public int Modelo { get; set; }
    public string Color { get; set; }
    public string Owner { get; set; }

    private int Encendido = 1;
    private int velocidad_actual = 0;

    public int maxvel { get; set; }

    public Carro(string nuevo_duenio, int _modelo, string _color, int _maxvel, string _marca)
    {
        this.Owner = nuevo_duenio;
        this.Modelo = _modelo;
        this.Color = _color;
        this.Marca = _marca;

        Console.WriteLine("Hola, tu carro esta creado y listo");
    }

    public void encender_carro()
    {
        if (Encendido == 0)
        {
            Console.WriteLine($"(this.Owner) tu carro lo encendido");
            Encendido = 1;
        }
        else
        {
            Console.WriteLine($"{this.Owner} tu carro ya estaba encendido");
        }
    }

    public void apagar_carro()
    {
        if (Encendido == 1)
        {
            Console.WriteLine($"{this.Owner} tu carro lo encendi");
            Encendido = 0;
        }
        else
        {
            Console.WriteLine($"(this.Owner) tu carro ya estaba encendido");
        }
    }

    public void acelerar(int meterCaite)
    {
        if (Encendido == 1)
        {
            velocidad_actual += meterCaite;
            Console.WriteLine($"{Owner} vas a {velocidad_actual}");
        }
    }
}
