using System.Collections;
using System.Collections.Generic;
using BaseTemplate.Behaviours;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Netcode;
using UnityEngine.Animations;

public class WeaponController : MonoBehaviour
{

    public float fireRate = 20f;

    public GameObject cameraGameObject; 


    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            fire();
        }
    }

    private void fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(cameraGameObject.transform.position, cameraGameObject.transform.forward, out hit))
        {
            Debug.DrawLine(cameraGameObject.transform.position, hit.point, Color.white, 1f);
        }
    }
    /* 
    [Header("Basics")]
    public Transform bulletOrigin;
    private bool _isPerformed = false;

    [Header("WeaponController Infos")] 
    public int ammo = 10;
    public int maxAmmo = 10;
    public float timeForReload = 2f;
    public ParticleSystem fxShoot;
    private float _cdTime;
    public float damage = 10f;
    

    [Header("Aim Infos")] 
    public GameObject aim;
    public LayerMask layerMask;
    private Camera _camera;
    private AimConstraint _constraint;
    
    public List<Weapon> weapons;
    public int indexWeapon;
    public Vector3 hitPoint;

    
    private void Start()
    {
        //if (!IsOwner) return;
        _camera = Camera.main;
        UIManager.Instance.ChangeAmmoText(ammo.ToString());
    }

    private void Update()
    {
        if (_cdTime >= 0)
        {
            _cdTime -= Time.deltaTime;
            
        }
        else
        {
            //SetAim();
        }

        if (_isPerformed && ammo <= 0)
        {
            StartCoroutine(Reload());
        }
    }

    public IEnumerator Reload()
    {
        yield return new WaitForSeconds(timeForReload);
        ammo = maxAmmo;
        UIManager.Instance.ChangeAmmoText(ammo.ToString());
    }

    public void Fire(InputAction.CallbackContext context)
    {

        if (context.started)
        {
            _isPerformed = true;
            fxShoot.Play();
            Shoot();
        }
            
        if (context.canceled)
            _isPerformed = false;
    }

     public void Shoot()
    { 
        weapons[indexWeapon].Shoot(SetAim());
    }
    
    
    public Transform SetAim()                                                                                                                                                                                             
    {
        //Tir d'un rayon
        Ray ray = new Ray(_camera.transform.position, _camera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit,layerMask))
        {
            //Ajustement de notre Aim en fonction du hitPoint, fonctionne avec un AimConstraint
            aim.transform.position = hit.point;
            hitPoint = hit.point;

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                 Debug.Log("Pendant le raycast");
                target.TakeDamage(damage);
            }
        }
        else
        {
            aim.transform.localPosition = new Vector3(0,0,10 );
        }
        return bulletOrigin;
    }
     */
   
}
