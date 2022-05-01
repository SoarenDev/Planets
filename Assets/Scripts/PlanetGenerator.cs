using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{

// = = = [ VARIABLES ] = = =

    public MeshFilter targetMeshFilter;
    public MeshRenderer targetMeshRenderer;

    private Mesh genMesh;

    private Vector3[] vertices;
    private int[] triangles;

[Header("Parameters")][Space(10)]
    public int planetTessellation = 3;


// = = =

    void Start()
    {
        Generate();
    }

// = = =

    void Generate()
    {
        CreateMesh(ref genMesh, 12);
        CreateShape();
        return;
    }

    void CreateMesh (ref Mesh mesh, int numVertices) 
    {
        IcoSphere.Create(targetMeshFilter, planetTessellation);
        return;
    }

    void CreateShape()
    {

        return;
    }

    /*
    for f in faces:
  origin = get_origin(f)
  right = get_right_dir(f)
  up = get_up_dir(f)
  for j in div_count:
    for i in div_count:
      p = origin + 2.0 * (right * i + up * j) / div_count
      p2 = p * p
      rx = sqrt(1.0 - 0.5 * (p2.y + p2.z) + p2.y*p2.z/3.0)
      ry = sqrt(1.0 - 0.5 * (p2.z + p2.x) + p2.z*p2.x/3.0)
      rz = sqrt(1.0 - 0.5 * (p2.x + p2.y) + p2.x*p2.y/3.0)
      return (rx, ry, rz)
      */


}
