namespace Academia;

public class Profissional
{
    public int Id {get; set;}

    public string Nome {get; set;} = string.Empty;

    public string Especialidade {get; set;} = string.Empty; 
    // Especialidade (Ex.: Musculação, Pilates, Nutrição)

    public string? UserId {get; set;} 
    // Id do usuário associado ao profissional (opcional)

    public List<Aula> Aulas {get; set;}
}
