using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float controlSpeed = 29f;
    [SerializeField] float xRange = 10f;
    [SerializeField] float yRange = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");

        float xoffset = xThrow * Time.deltaTime * controlSpeed;
        float rawXPos = transform.localPosition.x + xoffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);

        float yoffset = yThrow * Time.deltaTime * controlSpeed;
        float rawYPos = transform.localPosition.y + yoffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
    }
}
