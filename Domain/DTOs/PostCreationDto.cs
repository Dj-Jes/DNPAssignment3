namespace Domain.DTOs;

public class PostCreationDto {
    public string Title { get; set; }
    public string Body { get; set; }
    public string AuthorId { get; set; }
    public string SubPageId { get; set; }
}