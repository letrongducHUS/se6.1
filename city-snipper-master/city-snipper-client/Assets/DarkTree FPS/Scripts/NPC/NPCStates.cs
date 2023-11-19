/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

/// DarkTreeDevelopment (2019) DarkTree FPS v1.1
/// If you have any questions feel free to write me at email --- darktreedevelopment@gmail.com ---
/// Thanks for purchasing my asset!

using UnityEngine;
using UnityEngine.AI;

namespace DarkTreeFPS {

    public class NPCStates : MonoBehaviour {

        /// <summary>
        /// 1. Tactical runner will find cover out of player visibility range and try to keep distance. In some cases he can run behind player's back to attack
        /// 2. Seeker know player position and will be chase player to kill
        /// 3. Idle will stay on one place and attack player only if he in visibility range
        /// </summary>
        public enum EnemyTactics { Tactical, Seeker, Idle }
        /// <summary>
        /// 1. Idle is default behavior when enemy just stay on he's own position on the start
        /// 2. Patrol. Enemy will be walking through patrol points
        /// 3. FollowToTarget. Enemy will follow a target assigned to the targetToFollow field
        /// 4. Wander. Enemy will randomly wandering within navmesh
        /// </summary>
        public enum DefaultBehavior { Idle, Patrol, FollowToTarget, Wander }

        [Header("Enemy behavior types")]
        [Tooltip("Tactic to follow when NPC alarmed")]
        public EnemyTactics enemyTactics;
        [Tooltip("Default enemy state when idle")]
        public DefaultBehavior defaultBehavior;

        [Header("Patrol - behavior")]
        public Transform[] patrolPoints;
        [Range(0,1)]
        public float patrolSpeed = 0.5f;

        [Header("Target to follow - behavior")]
        public Transform targetToFollow;
        [Range(0,1)]
        public float followSpeed = 0.5f;

        [Header("Wandering - behavior")]
        public float radiusToTakeRandomPosition = 15;
        [Range(0,1)]
        public float wanderingSpeed = 0.5f;

        [Header("Seeker - behavior")]
        public float seekerStopingDistance = 1f;

        private NPC npc;

        private int wayPointIndex;

        private void Start()
        {
            npc = GetComponent<NPC>();

            
        }

        private void Update()
        {
            if (!npc.alarmed)
            {
                switch (defaultBehavior)
                {
                    case DefaultBehavior.FollowToTarget:
                        FollowToTargetBehavior();
                        break;
                    case DefaultBehavior.Idle:
                        //Do nothing
                        break;
                    case DefaultBehavior.Patrol:
                        PatrolBehavior();
                        break;
                    case DefaultBehavior.Wander:
                        WanderingBehavior();
                        break;
                    default:
                        //Do nothing
                        break;
                }
            }
            else
            {
                switch (enemyTactics)
                {
                    case EnemyTactics.Tactical:
                        TacticalBehavior();
                        break;
                    case EnemyTactics.Idle:
                        //Do nothing
                        break;
                    case EnemyTactics.Seeker:
                        SeekerBehavior();
                        break;
                    default:
                        break;
                }
            }
        }

        #region Tactic Behaviors

        private void TacticalBehavior()
        {
            npc.navMeshAgent.speed = 1;

            if (npc.alarmed && npc.destinationReached || npc.navMeshAgent.pathStatus == NavMeshPathStatus.PathPartial)
            {
                npc.lookAtTarget = true;
                npc.GetRandomPositonOutsidePlayerFOV(transform.position, 20);
                npc.destinationReached = false;
            }

            if (Vector3.Distance(transform.position, npc.navMeshAgent.destination) < npc.navMeshAgent.stoppingDistance)
            {
                npc.destinationReached = true;
            }
        }

        private void SeekerBehavior()
        {
            npc.navMeshAgent.speed = 1;

            if (!npc.alarmed)
                npc.alarmed = true;

            npc.desiredPosition = npc.player.transform.position;
            npc.navMeshAgent.stoppingDistance = seekerStopingDistance;
        }

        #endregion

        #region Default Behaviors

        private void PatrolBehavior()
        {
            npc.navMeshAgent.speed = patrolSpeed;
            npc.navMeshAgent.stoppingDistance = 1;

            npc.desiredPosition = patrolPoints[wayPointIndex].position;

            if (npc.navMeshAgent.remainingDistance <= npc.navMeshAgent.stoppingDistance)
            {
                wayPointIndex++;

                if (wayPointIndex == patrolPoints.Length)
                {
                    wayPointIndex = 0;
                }
            }
        }

        private void WanderingBehavior()
        {
            npc.navMeshAgent.stoppingDistance = 1f;
            npc.navMeshAgent.speed = wanderingSpeed;

            if (npc.navMeshAgent.remainingDistance <= npc.navMeshAgent.stoppingDistance)
            {
                npc.desiredPosition = npc.GetRandomPosition(transform.position, radiusToTakeRandomPosition, 1);
            }
        }

        private void FollowToTargetBehavior()
        {
            npc.navMeshAgent.speed = followSpeed;
            npc.desiredPosition = targetToFollow.position;
        }

        #endregion

    }
}
