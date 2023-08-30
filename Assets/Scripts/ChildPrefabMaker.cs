using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildPrefabMaker : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Child");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
        
    }

    public void MakeChild()
    {  
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Child");
        // Cubeプレハブを元に、インスタンスを生成、
        //Instantiate(obj, new Vector3(1.0f, 1.0f, 0.0f), Quaternion.identity);
        int i1 = Random.Range(0, 7), i2 = Random.Range(0, 7);
        Vector3 pos1 = pos[i1], pos2 = pos[i2];  //pos1とpos2にn番目の座標を入れる

        int i3 = Random.Range(0, 2); //i4 = Random.Range(0, 1);
        //GameObject obj = images[i3]; //obj2 = images[i4];

       Instantiate(obj, pos1, Quaternion.identity);
        Debug.Log(i1);
        //Instantiate(obj2, pos2, Quaternion.identity);
    }

    public List<Vector3> pos = new List<Vector3>();   //決められた10個の座標
    public List<GameObject> images = new List<GameObject>();  //画像を含んだゲームオブジェクト20個

    //Set()を呼び出してランダムに設置
    void Set()
    {
        int i1 = Random.Range(0, 2), i2 = Random.Range(0, 1);
        Vector3 pos1 = pos[i1], pos2 = pos[i2];  //pos1とpos2にn番目の座標を入れる

        int i3 = Random.Range(0, 2), i4 = Random.Range(0, 1);
        GameObject obj1 = images[i3], obj2 = images[i4];

        Instantiate(obj1, pos1, Quaternion.identity);
        //Instantiate(obj2, pos2, Quaternion.identity);

    }

}
