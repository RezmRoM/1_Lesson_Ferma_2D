	using UnityEngine; // Для работы с Unity Engine

/// <summary>
/// Класс, представляющий движение игрока
/// </summary>
public class Movement : MonoBehaviour // Объявление класса Movement, наследующего от MonoBehaviour
{
    public Sprite front; // Публичное поле для хранения спрайта игрока, смотрящего вперед
    public Sprite left; // Публичное поле для хранения спрайта игрока, смотрящего влево
    public Sprite right; // Публичное поле для хранения спрайта игрока, смотрящего вправо
    public Sprite back; // Публичное поле для хранения спрайта игрока, смотрящего назад

    public float moveSpeed; // Публичное поле для хранения скорости движения игрока
    private Rigidbody2D rigidbody2D; // Приватное поле для хранения ссылки на Rigidbody2D компонент игрока
    private SpriteRenderer spriteRenderer; // Приватное поле для хранения ссылки на SpriteRenderer компонент игрока
    private Vector2 moveDirection; // Приватное поле для хранения направления движения игрока
    private bool isMoving = false; // Приватное поле для хранения флага, указывающего, движется ли игрок

    /// <summary>
    ///  Метод, вызываемый перед первым кадром
    ///  Нахождение игрока в игре и его спрайт
    /// </summary>
    void Start() // Переопределение метода Start
    {
        rigidbody2D = this.GetComponent<Rigidbody2D>(); // Получение ссылки на Rigidbody2D компонент игрока
        spriteRenderer = this.GetComponent<SpriteRenderer>(); // Получение ссылки на SpriteRenderer компонент игрока
    }

    /// <summary>
    ///  Метод, вызываемый каждый кадр игры
    ///  Если есть касание на игровом поле, 
    ///  то переопределяем переменную "isMoving" в true, иначе false
    ///  Если персонаж двигается то пределяем в каком направлении 
    ///  ему двигатся от текщей позиции. Сдвигаем игрока на 0.5 в 
    ///  нужном направлении и меняем спрайт игрока
    ///  
    /// </summary>
    void Update() // Переопределение метода Update
    {
        if (Input.GetMouseButtonDown(0)) // Проверка нажатия левой кнопки мыши
        {
            isMoving = true; // Установка флага isMoving в true
        }
        else if (Input.GetMouseButtonUp(0)) // Проверка отпускания левой кнопки мыши
        {
            isMoving = false; // Установка флага isMoving в false
        }

        if (isMoving) // Если игрок двигается
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Получение позиции курсора мыши в мировых координатах
            moveDirection = (mousePosition - (Vector2)rigidbody2D.position).normalized; // Вычисление направления движения игрока

            if (moveDirection.y > 0.5f) // Если игрок движется вверх
            {
                spriteRenderer.sprite = back; // Установка спрайта игрока, смотрящего назад
            }
            else if (moveDirection.y < -0.5f) // Если игрок движется вниз
            {
                spriteRenderer.sprite = front; // Установка спрайта игрока, смотрящего вперед
            }
            else if (moveDirection.x > 0.5f) // Если игрок движется вправо
            {
                spriteRenderer.sprite = right; // Установка спрайта игрока, смотрящего вправо
            }
            else if (moveDirection.x < -0.5f) // Если игрок движется влево
            {
                spriteRenderer.sprite = left; // Установка спрайта игрока, смотрящего влево
            }
        }
    }

    /// <summary>
    /// Переодично обновляет положение игрока в игре, если он двигается
    /// </summary>
    void FixedUpdate() // Переопределение метода FixedUpdate
    {
        if (isMoving) // Если игрок двигается
        {
            rigidbody2D.MovePosition(rigidbody2D.position + moveDirection * moveSpeed * Time.fixedDeltaTime); // Перемещение игрока в направлении moveDirection с учетом скорости и времени
        }
    }
}	
