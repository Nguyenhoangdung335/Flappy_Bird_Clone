using UnityEngine;

public class TImeConTrol : MonoBehaviour
{
    public float fastenFactor = 0.01f;
    private float timeBeforeChange = 0;
    public flyingMechanism jump;

    public void Update()
    {
        timeBeforeChange += Time.deltaTime;
        if (timeBeforeChange > 10f)
        {
            DoFasten();
            timeBeforeChange = 0;
        }
    }

    public void DoFasten ()
    {
        Time.timeScale += fastenFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
