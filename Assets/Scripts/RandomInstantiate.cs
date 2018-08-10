using UnityEngine;
using System.Collections;

public class RandomInstantiate : MonoBehaviour {

    public GameObject prefab;
    private float time = 0;
    private float positionX, positionY;
    public static float speed = 1f;

    void Start()
    {
        speed = 1;
    }
    

    void Instantiate()
    {
        positionX = transform.position.x;
        positionY = transform.position.y;
        Vector3 position = new Vector3(positionX + Random.Range(-3.0f, 3.0f), positionY, 0);
        Instantiate(prefab, position, transform.rotation);  
    }

		
	// Update is called once per frame
	void Update () {
        
        time += Time.deltaTime *speed;
        if (time >= 2)
        {
            Instantiate();
            speed += speed * Time.deltaTime;
            time = 0;            
        }
	
	}
}
