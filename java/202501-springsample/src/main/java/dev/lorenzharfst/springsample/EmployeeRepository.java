public interface EmployeeRepository extends CrudRepository<Employee, Long> {
    List<Employee> findAll();
}
