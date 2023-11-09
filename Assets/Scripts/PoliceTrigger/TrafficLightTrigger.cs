using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightTrigger : MonoBehaviour
{
    public TrafficLightController tc;
    public GameObject policeCar;
    public Transform policecarSpawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (tc.isRedLight)
        {
            policeCar.transform.position = policecarSpawnPoint.position;
            policeCar.transform.rotation = policecarSpawnPoint.rotation;
            policeCar.SetActive(true);
            policeCar.GetComponent<PoliceCarChase>().SetTarget();
        }
    }
}
