using System.Collections;
using TMPro;
using UnityEngine;

public class FPSPlayerFire : MonoBehaviour
{
    private enum WeaponMode { Normal, Sniper, }
    private WeaponMode wMode;

    public GameObject firePosition;
    public GameObject bombFactory;
    public GameObject bulletEffect;
    private ParticleSystem ps;
    private Animator anim;

    public TextMeshProUGUI wModeText;
    public GameObject[] eff_Flash;

    public float throwPower = 15f;
    public int weaponPower = 5;

    private bool zoomMode = false;


    private void Start()
    {
        ps = bulletEffect.GetComponent<ParticleSystem>();
        anim = GetComponentInChildren<Animator>();

        wMode = WeaponMode.Normal;
    }

    private void Update()
    {
        if (FPSGameManager.Instance.gState != FPSGameManager.GameState.Run)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            if(anim.GetFloat("MoveMotion") == 0)
                anim.SetTrigger("Attack");

            StartCoroutine(ShootEffectOn(0.05f));

            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitInfo = new RaycastHit();

            if(Physics.Raycast(ray, out hitInfo))
            {
                if(hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy")) //Raycast를 Enemy가 맞은 경우
                {
                    EnemyFSM eFSM = hitInfo.transform.GetComponent<EnemyFSM>();
                    eFSM.HitEnemy(weaponPower);
                }
                else // Raycast가 맞은 대상이 Enemy가 아닌 경우
                {
                    bulletEffect.transform.position = hitInfo.point; // 레이저를 맞은 대상
                    bulletEffect.transform.forward = hitInfo.normal;

                    ps.Play();
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            switch (wMode)
            {
                case WeaponMode.Normal: // 일반 모드일 때 마우스 오른쪽 -> 수류탄 투척
                    GameObject bomb = Instantiate(bombFactory);
                    bomb.transform.position = firePosition.transform.position;

                    Rigidbody rb = bomb.GetComponent<Rigidbody>();
                    rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
                    break;
                case WeaponMode.Sniper: // 저격 모드일 때 마우스 오른쪽 -> 확대/축소 조준경
                    // if (!ZoomMode)
                    // {
                    //     Camera.main.fieldOfView = 15f;
                    //     ZoomMode = true;
                    // }
                    // else
                    // {
                    //     Camera.main.fieldOfView = 60f;
                    //     ZoomMode = false;
                    // }

                    float fov = zoomMode ? 60f : 15f;
                    Camera.main.fieldOfView = fov;
                    zoomMode = !zoomMode;
                    break;
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            wMode = WeaponMode.Normal;
            Camera.main.fieldOfView = 60f;
            wModeText.text = "Nomal Mode";
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            wMode = WeaponMode.Sniper;
            wModeText.text = "Sniper Mode";
        }
    }

    IEnumerator ShootEffectOn(float duration)
    {
        int num = Random.Range(0, eff_Flash.Length);
        eff_Flash[num].SetActive(true);
        
        yield return new WaitForSeconds(duration);
        eff_Flash[num].SetActive(false);
    }
}
