@EnableWebSecurity
public class WebSecurityConfig {
    @Bean
    public SecurityFilterChain filterChain(HttpSecurity http) throws Exception {
        http
            .authorizeRequests()
                .antMatchers(HttpMethod.GET, "/employees", "/employees/**")
                .permitAll()
            .anyRequest()
                .authenticated()
            .and()
                httpBasic();
        return http.build();
    }
}
