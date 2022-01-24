using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMove : MonoBehaviour
{
    InputController inputController;
    Animator animator;
    CharacterController cc;

    //boton + run
    bool botonrunning = false;
    bool running = false;

    //boton salto
    bool xbutton = false;

    // triggers
    float triggerL;
    float triggerR;

    // RB Apuntar
    bool rbutton;
    [SerializeField] GameObject pistola;

    // Boton disparar A
    bool abutton;

    //cc vars
    float frontspeed;
    float latspeed;
    /*Vector3 dirmov;
    Vector3 latmov;*/
    float girospeed = 1.5f;
    Vector3 vdirmov;
    
    //joystick L var
    Vector2 joystickL;

    //Camaras
    [SerializeField] GameObject freecam;
    [SerializeField] GameObject apuntadoCam;

    //tempori
    float tiempo;

    //bala
    [SerializeField] GameObject bala;

    //Se ejecuta antes del start
    private void Awake()
    {

        //Listeners Gamepad
        inputController = new InputController();

        //Boton correr
        inputController.Move.Run.performed += ctx => { botonrunning = true; };
        inputController.Move.Run.canceled += ctx => { botonrunning = false; };

        //Caminar Joystick L

        inputController.Move.Walking.performed += ctx => joystickL = ctx.ReadValue<Vector2>();
        inputController.Move.Walking.canceled += ctx => joystickL = Vector2.zero;

        //Triggers
        //L
        inputController.Move.LateralL.performed += ctx => triggerL = ctx.ReadValue<float>();
        inputController.Move.LateralL.canceled += ctx => triggerL = 0f;
        //R
        inputController.Move.LateralR.performed += ctx => triggerR = ctx.ReadValue<float>();
        inputController.Move.LateralR.canceled += ctx => triggerR = 0f;

        //Salto

        inputController.Move.Saltar.performed += ctx => xbutton = true;
        inputController.Move.Saltar.canceled += ctx => xbutton = false;

        //Apuntar
        inputController.Move.Apuntar.performed += ctx => rbutton = true;
        inputController.Move.Apuntar.canceled += ctx => rbutton = false;

        //Disparar
        inputController.Move.Disparar.performed += ctx => abutton = true;
        inputController.Move.Disparar.canceled += ctx => abutton = false;


    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //umbral correr
        if (botonrunning && joystickL.y > 0.8f)
        {
            running = true;
        }
        else
        {
            running = false;
        }

        //animator correr
        if (running == true && joystickL.y > 0.1f)
        {
            animator.SetBool("CorrerBool", true);

        }
        else
        {
            animator.SetBool("CorrerBool", false);
        }
        animator.SetBool("CorrerBool", running);

        //Animator Saltar

        if (xbutton == true)
        {
            animator.SetBool("Saltar", true);
        }
        else
        {
            animator.SetBool("Saltar", false);
        }

        // Animator lateral straffle

        float strafe = triggerL - triggerR;
     

        if (strafe != 0)
        {
            animator.SetBool("LateralBool", true);
        }
        else
        {
            animator.SetBool("LateralBool", false);
        }

        animator.SetFloat("LateralMov", strafe);

        
        // animator andar

        animator.SetFloat("Walk", joystickL.y);
        //animator pistola
        if (rbutton)
        {
            animator.SetBool("Apuntar", true);
        }
        else
        {
            animator.SetBool("Apuntar", false);
        }

        //Cambiar camara a apuntar + pistola
        if (rbutton)
        {
            freecam.SetActive(false);
            apuntadoCam.SetActive(true);
            pistola.SetActive(true);
        }
        else
        {
            freecam.SetActive(true);
            apuntadoCam.SetActive(false);
            pistola.SetActive(false);
        }



        //Character Controller Movimiento del personaje


        /*
        dirmov = transform.TransformDirection(Vector3.forward);
        latmov = transform.TransformDirection(Vector3.right);
        */
        //movimientos frontal y lateral
        latspeed = 2f;

        vdirmov = transform.TransformDirection(new Vector3 (latspeed*strafe*-1f, 0f, frontspeed*joystickL.y));
        //Correr o andar
        if (running == true && joystickL.y > 0.1f)
        {
            frontspeed = 8f;
        }
        if (running == false)
        {
            frontspeed = 3f;
        }

        //temporización guardar arma antes de empezar a andar
        if (rbutton == false && tiempo <= 0f)
        {
            cc.SimpleMove(vdirmov);
            tiempo = 0f;
        }
        if (rbutton == true)
        {
            tiempo = 1f;
        }
        if (rbutton == false && tiempo > 0f)
        {
            tiempo = tiempo - (1f * Time.deltaTime);
        }


        //Giro
        transform.Rotate(new Vector3(0f, joystickL.x * girospeed, 0f));

        //umbral giro
       if(joystickL.x >0.35f || joystickL.x <-0.35f)
        {
            girospeed = 1.5f;
        }
        else
        {
            girospeed = 0.0f;
        }
        //saltar
        /*if(xbutton == true)
         {

         }*/


        //diparar bala
      if(rbutton && abutton)
        {
            Instantiate(bala);
        }
       

    }

    private void OnEnable()
    {
        inputController.Enable();
    }
    private void OnDisable()
    {
        inputController.Disable();
    }

}
