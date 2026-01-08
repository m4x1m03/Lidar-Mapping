using UnityEngine;
using UnityEngine.InputSystem;
public class LidarPointVisualizer : MonoBehaviour
{
    public Camera lidarCamera;
    public Material pointMaterial;
    public float pointSize = 0.05f;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            float fakeDistance = Random.Range(0.5f, 10f);
            SpawnPoint(fakeDistance);
        }
    }


    Color DistanceToColor(float distance, float maxDistance)
    {
        float t = Mathf.Clamp01(distance / maxDistance);

        if (t < 0.5f)
        {
            // Green → Yellow
            return Color.Lerp(Color.green, Color.yellow, t * 2f);
        }
        else
        {
            // Yellow → Red
            return Color.Lerp(Color.yellow, Color.red, (t - 0.5f) * 2f);
        }
    }


    public float maxDistance = 10f;

    public void SpawnPoint(float distance)
    {
        Vector3 origin = lidarCamera.transform.position;
        Vector3 direction = lidarCamera.transform.forward;
        Vector3 pointPosition = origin + direction * distance;

        GameObject point = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        point.transform.position = pointPosition;
        point.transform.localScale = Vector3.one * pointSize;

        Renderer r = point.GetComponent<Renderer>();
        r.material = new Material(pointMaterial); // instance per point
        r.material.color = DistanceToColor(distance, maxDistance);

        Destroy(point.GetComponent<Collider>());
    }

}
