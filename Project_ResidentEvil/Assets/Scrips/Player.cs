using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : InputManager
{
    [SerializeField]
    float moveSpd;
    [SerializeField]
    float runSpd;
    [SerializeField]
    float rotationSpd;

    Rigidbody rigid;

    //Inventory Tutorial Start
    public static Player Instance;

    public int Health;

    public TextMeshProUGUI HealthText;

    public void IncreaseHealth(int value)
    {
        Health += value;
        HealthText.text = $"HP : {Health}";
    }

    private void Awake()
    {
        Instance = this;
    }

    //Inventory Tutorial End
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveWASD();
    }
    // Movement during WASD Input
    void MoveWASD()
    {
        float spd;

        if (InputShift()&&InputWASD().x==1)
        {
            spd = runSpd;
        }
        else
        {
            spd = moveSpd;
        }
        
        // Move forward, back
        rigid.MovePosition(
            transform.position + transform.forward * InputWASD().x * spd * Time.deltaTime);

        // Rotation left, right
        transform.Rotate(Vector3.up, rotationSpd * InputWASD().y * Time.deltaTime);
    }

}
