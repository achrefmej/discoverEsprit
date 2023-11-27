using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationEvents : MonoBehaviour
{
    [SerializeField] GameObject AgoraCanvas;
    [SerializeField] GameObject ConversationCanvas;
    [SerializeField] GameObject Door;

    public void Opendoor()
    {
        Door.transform.Rotate(0, 0, 50);
     }

    public void EnableChannel()
    {
        AgoraCanvas.SetActive(true);
    }

    public void DestroyConversation()
    {
        Destroy(ConversationCanvas);
    }


            



    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
