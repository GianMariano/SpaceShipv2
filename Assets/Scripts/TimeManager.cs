using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance;

    [Header("Configurações de Slow Motion")]
    public float slowdownFactor = 0.5f; // Velocidade reduzida (50%)
    public float slowdownDuration = 3f; // Tempo de duração
    public GameObject slowMotionFilter;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        if (slowMotionFilter != null)
            slowMotionFilter.SetActive(false); // Garante que começa desativado
    }

    // Chamado quando o jogador atinge 500 pontos
    public void ActivateSlowMotion()
    {
        slowMotionFilter.SetActive(true);
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f; // Ajusta a física
        Invoke("ReturnToNormalTime", slowdownDuration);
    }

    private void ReturnToNormalTime()
    {
        slowMotionFilter.SetActive(false);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
    }
}
