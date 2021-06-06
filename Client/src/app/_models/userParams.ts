import { User } from "./user";

export class UserParams {
  gender!: string;
  minAge = 18;
  maxAge = 150;
  pageNumber = 1;
  pageSize = 5;

  constructor(user: User | any) {
    this.gender = user.gender === 'female' ? 'male' : 'female';
  }

}
