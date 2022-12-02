using MediatorDemo.Library.Models;
using MediatR;

namespace MediatorDemo.Library.Commands
{
    public record AddStudentCommand(StudentModel request):IRequest<StudentModel>;
}
