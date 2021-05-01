using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OpenHardwareMonitor.Hardware;

public class PCResourceManager : MonoBehaviour
{
    public GameObject GPU_Temp;
    public GameObject GPU_Usage;
    public GameObject CPU_Usage;
    public float interval;

    Computer thisPC;

    float gpuTemp = 0;
    float gpuUsage = 0;
    float cpuUsage = 0;
    float time = 0;
      
    void Start()
    {
        thisPC = new Computer() { CPUEnabled=true, GPUEnabled=true, MainboardEnabled=true, HDDEnabled=true };
        thisPC.Open();
    }

    void Update()
    {
        if (time > interval)
        {
            UpdatePCStatus(thisPC);
            time = 0;
        }
        
        time = time + Time.deltaTime;
    }

    void UpdatePCStatus(Computer pc)
    {
        foreach (var hardware in pc.Hardware)
        {
            switch (hardware.HardwareType)
            {
                case HardwareType.CPU:
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType==SensorType.Load && sensor.Name=="CPU Total")
                        {
                            cpuUsage = sensor.Value.HasValue ? sensor.Value.Value : -1;
                            break;
                        }
                    }
                    break;

                case HardwareType.GpuNvidia:
                    hardware.Update();
                    int sensorCount = 0;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType==SensorType.Load && sensor.Name=="GPU Core")
                        {
                            gpuUsage = sensor.Value.HasValue ? sensor.Value.Value : -1;
                            sensorCount++;
                        }
                        else if (sensor.SensorType==SensorType.Temperature && sensor.Name=="GPU Core")
                        {
                            gpuTemp = sensor.Value.HasValue ? sensor.Value.Value : -1;
                            sensorCount++;
                        }

                        if(sensorCount==2)
                            break;
                    }
                    break;
            }

            UpdateStatusBar();
        }
    }


    void UpdateStatusBar()
    {
        GPU_Temp.transform.Find("Value").GetComponent<Text>().text = gpuTemp.ToString() + "°C";
        GPU_Temp.transform.Find("Graph/CircleGauge").GetComponent<Image>().fillAmount = gpuTemp/100;

        GPU_Usage.transform.Find("Value").GetComponent<Text>().text = gpuUsage.ToString() + "%";
        GPU_Usage.transform.Find("Graph/CircleGauge").GetComponent<Image>().fillAmount = gpuUsage/100;

        CPU_Usage.transform.Find("Value").GetComponent<Text>().text = Mathf.Round(cpuUsage).ToString() + "°%";
        CPU_Usage.transform.Find("Graph/CircleGauge").GetComponent<Image>().fillAmount = cpuUsage/100;
    }
}
