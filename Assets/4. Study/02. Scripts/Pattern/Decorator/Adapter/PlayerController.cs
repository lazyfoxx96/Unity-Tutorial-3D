using UnityEngine;

namespace Pattern.Adapter
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject player;

        private ICharacter character;

        private void Start()
        {
            character = player.GetComponent<ICharacter>();

            character.Move(Vector3.forward);

            character.Attack();


        }
    }
}
