using MediatorDemo.Library.Commands;
using MediatorDemo.Library.Data;
using MediatorDemo.Library.Models;
using MediatR;

namespace MediatorDemo.Library.Handlers
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, StudentModel>
    {
        private readonly IDataRepository _dataRepository;

        public AddStudentHandler(IDataRepository dataRepository) =>
            (_dataRepository) = (dataRepository);

        public Task<StudentModel> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.AddStudent(request.request));            
        }
    }
}
