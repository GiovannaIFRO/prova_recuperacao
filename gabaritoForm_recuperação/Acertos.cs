public class Acertos
{
    public string nome;
    public string matricula;
    public string respostas;

    public int QtdAcertos(string[] respostas)
    {
        string[] gabarito = { "A", "B", "C", "E", "A", "D", "D", "B", "C", "E" };
        int cont = 0;

        for (int i = 0; i < gabarito.Length; i++)
        {
            if (gabarito[i] == respostas[i])
            {
                cont++;
            }
        }

        return cont;
    }

   
}