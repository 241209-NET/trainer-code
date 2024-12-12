namespace OOP;

public interface ICrashable
{
    bool IsTotaled { get; set; }

    void Destroy();
}