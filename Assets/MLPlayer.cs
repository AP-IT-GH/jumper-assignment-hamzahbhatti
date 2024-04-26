using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class MLPlayer : Agent
{


    private Rigidbody rb;
    private Transform orig;
    public Vector3 jump;
    public float jumpHeight = 7f;
    private bool isGrounded;


    // Initialize replaces the Start() function
    public override void Initialize()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionZ;
        orig = this.transform;
        Debug.Log("object: " + this.transform);
        //orig.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        int action = actions.DiscreteActions[0];

        if (isGrounded)
        {
            SetReward(0.01f);
        }
        if (action == 1)
          {
              Thrust();
            SetReward(-0.01f);
        }

    }

    public override void CollectObservations(VectorSensor sensor)
    {
        Debug.Log(sensor);
        sensor.AddObservation(this.transform.localPosition);
        Debug.Log("observation added");
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("ob") == true)
        {
            Debug.Log("touched obstacle");
            AddReward(-1.0f);
            Destroy(collision.gameObject);
            EndEpisode();
        }
   
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("road"))
        {
            isGrounded = true;
        }

    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("road"))
        {
            isGrounded = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("wallreward") == true)
        {
            Debug.Log("touched wall");
            AddReward(1.0f);
            EndEpisode();
        }
    }

    public override void OnEpisodeBegin()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        ResetPlayer();
    }

    private void Thrust()
    {
        rb.AddForce(jump * jumpHeight, ForceMode.Impulse);
    }

    private void ResetPlayer()
    {
        this.transform.position = new Vector3(orig.position.x, orig.position.y, orig.position.z);
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {

        var discreteActionsOut = actionsOut.DiscreteActions;
        discreteActionsOut[0] = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            discreteActionsOut[0] = 1;
        }
    }
}
