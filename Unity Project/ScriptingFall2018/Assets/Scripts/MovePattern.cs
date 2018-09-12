using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class MovePattern : ScriptableObject {

    public FloatData jumpSpeed;
    public FloatData gravity;
    public FloatData MoveX, MoveY, MoveZ;
    public FloatData Rotx, Roty, Rotyz;
	
    private Vector3 moveDirection;
    private Vector3 rotDirection;

    public void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded) {
            moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
            rotDirection.Set(Rotx.Value, Roty.Value, Rotyz.Value);
            transform.Rotate(rotDirection);
            moveDirection = transform.TransformDirection(moveDirection);
        }
        moveDirection.y -= gravity.Value * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
