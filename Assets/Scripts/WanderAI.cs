using ithappy.Animals_FREE;
using UnityEngine;

[RequireComponent(typeof(CreatureMover))]
public class WanderAI : MonoBehaviour
{
    private CreatureMover mover;

    [Header("Wander Settings")]
    [SerializeField] private float walkTimeMin = 2f;
    [SerializeField] private float walkTimeMax = 4f;

    [SerializeField] private float idleTimeMin = 1f;
    [SerializeField] private float idleTimeMax = 2.5f;

    [SerializeField] private bool canRun = true;

    private float timer;
    private Vector2 moveAxis;
    private Vector3 lookTarget;
    private bool isMoving;
    private bool isRun;

    private void Awake()
    {
        mover = GetComponent<CreatureMover>();
        DecideNextState();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            DecideNextState();
        }

        mover.SetInput(
            isMoving ? moveAxis : Vector2.zero,
            lookTarget,
            isRun,
            false
        );
    }

    private void DecideNextState()
    {
        // 70% đi, 30% đứng
        isMoving = Random.value > 0.3f;

        if (isMoving)
        {
            timer = Random.Range(walkTimeMin, walkTimeMax);

            Vector2 dir = Random.insideUnitCircle.normalized;
            moveAxis = dir;

            lookTarget = transform.position + new Vector3(dir.x, 0f, dir.y) * 5f;

            isRun = canRun && Random.value > 0.7f;
        }
        else
        {
            timer = Random.Range(idleTimeMin, idleTimeMax);
            isRun = false;

            // vẫn giữ hướng nhìn cũ cho tự nhiên
            lookTarget = transform.position + transform.forward;
        }
    }
}
