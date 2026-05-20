internal class Parcela
{
    public string tipoCultivo;
    public int tiempoRestante;
    public bool ocupada;
    public double gananciaEsperada;

    public Parcela(string tipoCultivo, int tiempoRestante, bool ocupada, double gananciaEsperada)
    {
        this.tipoCultivo = tipoCultivo;
        this.tiempoRestante = tiempoRestante;
        this.ocupada = ocupada;
        this.gananciaEsperada = gananciaEsperada;
    }

    public void Sembrar()
    {
        ocupada = true;
    }

    public void Crecer()
    {
        if (ocupada && tiempoRestante > 0)
        {
            tiempoRestante--;
        }
    }

    public double Cosechar()
    {
        if (ocupada && tiempoRestante == 0)
        {
            ocupada = false;
            return gananciaEsperada;
        }

        return 0;
    }
}

