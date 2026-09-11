namespace Academia;

public class Plano
{
    public int id {get; set;}

    public string Nome {get; set;} = string.Empty; 
    // Nome do plano, = string.Empty significa valor vazio 

    public decimal ValorMensal {get; set;}

    public int DuracaoMeses {get; set;}

    public List<Matricula>? Matriculas {get; set;} // Matriculas associada a planos
}