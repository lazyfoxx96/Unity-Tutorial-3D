using UnityEngine;
using UnityEngine.InputSystem;
namespace NewInputSystem
{ 
public class PlayerController3 : MonoBehaviour
{
        private CharacterController cc;

        public float speed = 5f;

        private Vector2 moveInput;

        private void Start()
        {
            cc = GetComponent<CharacterController>();
        }

        private void Update()
        {
            var dir = new Vector3(moveInput.x, 0, moveInput.y);

            cc.Move(dir * speed * Time.deltaTime);
        }

        private void OnMove(InputValue value)
        {
            moveInput = value.Get<Vector2>();
        }

        private void OnJump(InputValue value)
        {
            bool isJump = value.isPressed;
            Debug.Log("OnJump");
        }

        private void OnInteraction(InputValue value)
        {
            bool isInteraction = value.isPressed;
            Debug.Log("OnInteraction");
        }

        private void OnAttack(InputValue value)
        {
            Debug.Log("OnAttack");
        }
    }
}
