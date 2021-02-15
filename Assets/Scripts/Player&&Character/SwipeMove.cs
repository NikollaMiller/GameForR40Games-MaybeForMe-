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

            if (RoatationPlayer.rotated == 0)
            {
                if ((endTouchPosition.x < startTouchPosition.x) && !NoMove._noGoRight)
                    transform.position = new Vector3(transform.position.x - 1.8f, transform.position.y, transform.position.z);
                else if ((endTouchPosition.x > startTouchPosition.x) && NoMove._noGoRight)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

                if ((endTouchPosition.x > startTouchPosition.x) && !NoMove._noGoLeft)
                    transform.position = new Vector3(transform.position.x + 1.8f, transform.position.y, transform.position.z);
                else if ((endTouchPosition.x > startTouchPosition.x) && NoMove._noGoLeft)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            else if (RoatationPlayer.rotated == 1)
            {
                if ((endTouchPosition.x < startTouchPosition.x) && !NoMove._noGoRight)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.8f);
                else if ((endTouchPosition.x < startTouchPosition.x) && NoMove._noGoRight)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

                if ((endTouchPosition.x > startTouchPosition.x) && !NoMove._noGoLeft)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.8f);
                else if ((endTouchPosition.x > startTouchPosition.x) && NoMove._noGoLeft)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                if ((endTouchPosition.x < startTouchPosition.x) && !NoMove._noGoRight)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.8f);
                else if ((endTouchPosition.x < startTouchPosition.x) && NoMove._noGoRight)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

                if ((endTouchPosition.x > startTouchPosition.x) && !NoMove._noGoLeft)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.8f);
                else if ((endTouchPosition.x > startTouchPosition.x) && NoMove._noGoLeft)
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
        }
    }    
}
