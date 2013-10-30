/*public Transform target;
public int moveSpeed;
public int rotationSpeed;
public int maxDistance;

private Transform myTransform;

void Awake() {
    myTransform = transform;
}

CharacterController character;

void Start () {
    GameObject go = GameObject.FindGameObjectWithTag("Player");
    target = go.transform;
    character = GetComponent<CharacterController>();
    maxDistance = 2;   
}

void Update () {
    Debug.DrawLine(target.position, myTransform.position, Color.yellow);
    Vector3 dir = target.position - myTransform.position;
    dir.y = 0; // kill height differences to avoid enemy tilting
    myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(dir), rotationSpeed * Time.deltaTime);
    if (dir.magnitude > maxDistance) {
        character.Move(myTransform.forward * moveSpeed * Time.deltaTime);
    }
}*/