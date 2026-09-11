namespace Academia;

public class Produto
{
    public int Id {get; set;}

    public string Nome {get; set;} = string.Empty; 
    // Nome do produto, ex.: Whey, Creatina, Squeeze....

    public decimal Preco {get; set;}

    public int Estoque {get; set;}
}
