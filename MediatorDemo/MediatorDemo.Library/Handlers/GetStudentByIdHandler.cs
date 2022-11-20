using MediatorDemo.Library.Data;
using MediatorDemo.Library.Models;
using MediatorDemo.Library.Queries;
using MediatR;

namespace MediatorDemo.Library.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, StudentModel>
    {
        private readonly IDataRepository _repository;

        public GetStudentByIdHandler(IDataRepository repository)
        => (_repository) = (repository);
        public Task<StudentModel> Handle(GetStudentByIdQuery request, 
                                         CancellationToken cancellationToken)
        {
            return Task.FromResult(this._repository.GetStudentById(request.id));
        }
    }
}
