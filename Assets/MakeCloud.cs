// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class MakeCloud : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public GameObject Cloud;
//     public float timediff;
//     float timer = 0;
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {
//         timer += Time.deltaTime;
//         if(timer > timediff)
//         {
//             GameObject newCloud = Instantiate(Cloud);
//             newCloud.transform.position = new Vector3(Random.Range(-1.5f, 1.65f), Random.Range(-0.5f, 4f), 0);
//             timer = 0;
//         }
//     }
// }
