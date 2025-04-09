using UnityEngine;

public class teste : MonoBehaviour
{
    Carro fusca = new Carro();
    //Carro gol = new Carro();
    void Start()
    {
        fusca.AtribuirNome("fusca de pai");
        Debug.Log("0 "+ fusca.NomeDoCarro());    
    }
    
    void Update()
    {
        
    }
}
