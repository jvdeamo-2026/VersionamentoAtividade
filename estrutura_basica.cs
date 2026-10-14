// 1. Bibliotecas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2. Requisição de componentes (Exige que o GameObject tenha um Rigidbody)
[RequireComponent(typeof(Rigidbody))]

// 3. Criação de classe (Herda de MonoBehaviour padrão da Unity)
public class EstruturaBasica : MonoBehaviour
{
    // 4. Criação de variáveis
    public float velocidadeDeMovimento = 5.0f;
    public string nomeDoPersonagem = "Jogador 1";
    private Rigidbody rb; // Variável privada para armazenar o componente

    // 5. Criação de métodos
    
    // Método Start é chamado antes do primeiro frame
    void Start()
    {
        // Atribuindo o componente Rigidbody à variável
        rb = GetComponent<Rigidbody>();
        Debug.Log("O script iniciou para o personagem: " + nomeDoPersonagem);
    }

    // Método Update é chamado uma vez por frame
    void Update()
    {
        ExecutarAcao();
    }

    // Criação de um método personalizado
    private void ExecutarAcao()
    {
        // Lógica simples de demonstração
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(nomeDoPersonagem + " executou uma ação!");
        }
    }
}
