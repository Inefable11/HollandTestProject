export  class CredencialesUsuaroBE {
    username:  string;
    password:  string;
    typeLogin: number;
    /**
     *
     */
    constructor(user) {
        this.username = user.id || '';
        this.password = user.password || '';
        this.typeLogin = user.typeLogin || 0;
    }
}
