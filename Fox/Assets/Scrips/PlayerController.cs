using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller; //vai buscar o controlador do jogador
    public Transform groundCheck; //vai buscar o objeto vazio

    public float speed = 12f; //velocidade de movimento
    public float gravity = 10f; //constante de queda
    public float jumpHeight = 3f; //alcance maximo de salto
    public float detectRadius = 0.2f; //raio que forma a circunferencia no objeto vazio que detecta o chão
    public LayerMask detection; //define o que pode detetar
    bool isGrounded; //guarda se está guardado

    Vector3 velo; //guarda a velocidade do objeto
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, detectRadius, detection); //deteta se esta a colidir com algo

        if (isGrounded && velo.y < 0)
        {
            velo.y = -2f;
        }

        float hMove = Input.GetAxis("Horizontal"); //deteta se as teclas A ou D estão a ser premidas
        float vMove = Input.GetAxis("Vertical"); //deteta se as teclas S ou W estão a ser premidas

        velo.y += -gravity * Time.deltaTime; //calcula a velocidade de queda
        Vector3 movement = transform.right * -vMove + transform.forward * hMove; //calcula o movimento em X e em Z

        controller.Move(movement * speed * Time.deltaTime); 

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            velo.y = Mathf.Sqrt(jumpHeight * -2f * -gravity); //define a velocidade necessaria pra alcançar jumpHeight
        }

        controller.Move(velo * Time.deltaTime);
        
    }
}
