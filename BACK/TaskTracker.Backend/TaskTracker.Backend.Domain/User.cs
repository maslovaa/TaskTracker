namespace TaskTracker.Backend.Domain;

/// <summary>
/// Модель пользователя.
/// </summary>
public class User : IEntity<int>
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Фамилия.
    /// </summary>
    public string Surname { get; set; }
    /// <summary>
    /// Отчество.
    /// </summary>
    public string? Patronymic { get; set; }
    /// <summary>
    /// Имя пользователя в системе.
    /// </summary>
    public string UserName { get; set; }
    /// <summary>
    ///  Электронная почта.
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Признак активности.
    /// </summary>
    public bool IsActive { get; set; }
}