using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome;
    private string energia;
    private int forca_ataque;
    private int forca_do_pulo;
    private int velocidade;
    private int numero_de_pes;
    private int numero_de_maos;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }
    public string Nome()
    {
        return this.nome;
    }
    private void Atribuirenergia(string energia)
    {
        this.energia = energia;
    }
    public string Energia()
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
    private void Atribuirforca_velocidade(int forca_velocidade)
    {
        this.velocidade = forca_velocidade;
    }
    public void Velocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }
    
    
    
    
    
    
    
    
    
}

