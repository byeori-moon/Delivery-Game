using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightTrigger : MonoBehaviour
{
    public TrafficLightController tc;
    public GameObject policeCar;
    public Vector3 policecarSpawnPoint;
    public Quaternion policecarRotation;

    private void OnTriggerEnter(Collider other)
    {
        if (tc.isRedLight)
        {
            policeCar.transform.position = policecarSpawnPoint;
            policeCar.transform.rotation = policecarRotation;
            policeCar.SetActive(true);
            policeCar.GetComponent<PoliceCarChase>().SetTarget();
        }
    }
}
