using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Het object dat de camera moet volgen (de speler)
    public Transform target;

    // Afstand van de camera t.o.v. de speler
    public Vector3 offset = new Vector3(0f, 3f, -6f);

    // Hoe soepel de camera beweegt
    public float smoothSpeed = 10f;

    void LateUpdate()
    {
        // LateUpdate gebruiken zodat de speler eerst beweegt
        if (target == null) return;

        // Bereken gewenste positie (altijd achter de speler)
        Vector3 desiredPosition = target.TransformPoint(offset);

        // Beweeg de camera soepel naar de gewenste positie
        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );

        // Laat de camera naar de speler kijken
        transform.LookAt(target.position + Vector3.up);
    }
}