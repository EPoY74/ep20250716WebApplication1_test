namespace HttpClietnTestApp.Models
{
    /// <summary>
    /// /Представляет человека с идентификатором, именем, и возрастом
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Уникальный идентификатор. Проверка на уникальность не реализована
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name { get; set; } = String.Empty;
        
        /// <summary>
        /// Возраст человека
        /// </summary>
        public int Age { get; set; }
    }
}
