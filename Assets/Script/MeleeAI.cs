using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI;
using UnityEngine.UI;
using UnityEngine.AI;
using Unity.VisualScripting;
using System.Diagnostics;

public class MeleeAI : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    public GameObject Cam, AIHead;
    public List<Animator> animations;
    public float CooldownDuration = 1f;
    public float Damage;
    bool cooldown = true;
    private Stopwatch timer=new Stopwatch();
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Cam = GameObject.Find("Main Camera");
        agent = gameObject.GetComponent<NavMeshAgent>();
        Stopwatch timer = new Stopwatch();
        this.timer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(player.transform.position.x - transform.position.x) <= 30 && Mathf.Abs(player.transform.position.z - transform.position.z) <= 30)
        {
            AIHead.transform.LookAt(new Vector3(Cam.transform.position.x, AIHead.transform.position.y, Cam.transform.position.z));
            AIHead.transform.rotation = Quaternion.Euler(-90, AIHead.transform.rotation.eulerAngles.y, AIHead.transform.rotation.eulerAngles.z);
            agent.SetDestination(player.transform.position);
        }
        if (Mathf.Abs(player.transform.position.x - transform.position.x) <= 6 && Mathf.Abs(player.transform.position.z - transform.position.z) <= 6)
        {
            for (int i = 0; i < animations.Count; i++)
            {
                animations[i].Play("Base Layer.RoboAttack", 0);

            }
            
           UnityEngine.Debug.Log(timer.ElapsedMilliseconds);
            if (this.timer.ElapsedMilliseconds >= 1000)
            {
                player.GetComponent<Health>().TakeDam(Damage);
                this.timer.Restart();
                this.timer.Start();
            }
        }
        else
        {
            for (int i = 0; i < animations.Count; i++)
            {
                animations[i].Play("Base Layer.New State", 0);
            }
        }
    }
    public IEnumerator StartCooldown()
    {
        cooldown = false;
        yield return new WaitForSeconds(CooldownDuration);
        cooldown = true;
    }
}