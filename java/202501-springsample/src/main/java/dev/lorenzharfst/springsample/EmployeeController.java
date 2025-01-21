@RestController
public class EmployeeController {
    @Autowired
    private EmployeeRepository repository;
    @GetMapping("/employees")
    public List<Employee> getEmployees() {
        return repository.findAll();
    }
}
