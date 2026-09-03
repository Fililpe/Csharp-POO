namespace Aula_04;

class Carro
{
    public string marca;
    public string modelo;
    public string versao;
    public int velocidadeFinal;

    //CONSTRUTOR
    public Carro(string mar, string mod, string ver, int velo)
    {
        marca = mar;
        modelo = mod;
        versao = ver;
        velocidadeFinal = velo;
    }
    
    
    //METODOS
    public string informacaoDescricao()
    {
        String texto = $"O carro é da marca: {marca}, modelo: {modelo}, versao: {versao}";
        return texto;
    }
    
}





