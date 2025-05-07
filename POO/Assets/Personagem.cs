using UnityEngine;

public class Personagem : MonoBehaviour
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ]
    private int energia;
    [ SerializeField ]
    private int forca_ataque;
    [ SerializeField ]
    private int forca_do_pulo;
    [ SerializeField ]
    private int velocidade;
    [ SerializeField ]
    private int numero_de_pes;
    [ SerializeField ]
    private int numero_de_maos;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }
    public string Nome()
    {
        return this.nome;
    }
    public void Atribuirenergia(int energia)
    {
        this.energia = energia;
    }
    public int Energia()
    {
        return this.energia;
    }

    private void Atribuirforca_ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }
    public int Forca_ataque()
    {
        return this.forca_ataque;
    }
    private void Atribuirforca_do_pulo(int forca_do_pulo)
    {
        this.forca_do_pulo = forca_do_pulo;
    }
    public int Forca_do_pulo()
    {
        return this.forca_do_pulo;
    }
    
    public void AtribuirVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public int Velocidade()
    {
        return this.velocidade;
    }

    private void Atribuirnumero_de_pes(int numero_de_pes)
    {
        this.numero_de_pes = numero_de_pes;
    }
    public int Numero_de_pes(int numero_de_pes)
    {
        return this.numero_de_pes;
    }

    private void Atribuirnumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }
    public int Numero_de_maos(int numero_de_maos)
    {
        return this.numero_de_maos;
    }
    
    
    
    
    
}

