using UnityEngine;

public class SwipeMove : MonoBehaviour {

    private Vector3 startTouchPosition, endTouchPosition;

    private void Update()
    {

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                startTouchPosition = Input.GetTouch(0).position;
    
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                endTouchPosition = Input.GetTouch(0).position;
    
                switch (RoatationPlayer.rotated)
                {
                    case 0:
                    {
                        if ((endTouchPosition.x < startTouchPosition.x) && !NoMove._noGoRight)
                            transform.position = new Vector3(transform.position.x - 1.7289994f, transform.position.y, transform.position.z);
                        else if ((endTouchPosition.x > startTouchPosition.x) && NoMove._noGoRight)
                            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    
                        switch (endTouchPosition.x > startTouchPosition.x)
                        {
                            case true when !NoMove._noGoLeft:
                                transform.position = new Vector3(transform.position.x + 1.7289994f, transform.position.y, transform.position.z);
                                break;
                            case true when NoMove._noGoLeft:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                                break;
                        }
                        break;
                    }
                    case 1:
                    {
                        switch (endTouchPosition.x < startTouchPosition.x)
                        {
                            case true when !NoMove._noGoRight:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.7289994f);
                                break;
                            case true when NoMove._noGoRight:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                                break;
                        }
    
                        switch (endTouchPosition.x > startTouchPosition.x)
                        {
                            case true when !NoMove._noGoLeft:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.7289994f);
                                break;
                            case true when NoMove._noGoLeft:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                                break;
                        }
                        break;
                    }
                    default:
                    {
                        switch (endTouchPosition.x < startTouchPosition.x)
                        {
                            case true when !NoMove._noGoLeft:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.7289994f);
                                break;
                            case true when NoMove._noGoLeft:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                                break;
                        }
    
                        switch (endTouchPosition.x > startTouchPosition.x)
                        {
                            case true when !NoMove._noGoRight:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.7289994f);
                                break;
                            case true when NoMove._noGoRight:
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                                break;
                        }
                        break;
                    }
                }
            } 
    }  

}
