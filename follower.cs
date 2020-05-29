using UnityEngine;
using System.Collections;
public class follower : MonoBehaviour
{

    public GameObject target;
    public float TargetDistance;
    public float AllowedDistance = 1f;
    public float FollowSpeed;
    public RaycastHit Shot;
    public Animator animator;


    void Start()
    {

        animator = GetComponent<Animator>();
    }
    void Update()
    {
        transform.LookAt(target.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;

            if (TargetDistance >= AllowedDistance)
            {

                
                if (TargetDistance > 4)
                {
                    animator.SetInteger("isWalking", 5);
                    FollowSpeed = 0.005f * Mathf.Pow(2.71828f, (TargetDistance - 5f / 3f));

                }
                else
                {
                    animator.SetInteger("isWalking", 0);
                    FollowSpeed = 0.009f;
                }
                //FollowSpeed = 0.005f*Mathf.Pow(2.71828f,(TargetDistance-5f/3f));
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, FollowSpeed);
            }
            else
            {

                animator.SetInteger("isWalking", Random.Range(1, 4));
                FollowSpeed = 0;
            }
        }
        //this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = target.transform.position;
    }
}