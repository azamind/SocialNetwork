import { Photo } from "./photo";

export interface Member {
  id: number;
  userName: string;
  knownAs: string;
  photoUrl: string;
  age: number;
  dateOfBirth: Date;
  lastActive: Date;
  created: Date;
  gender: string;
  introduction: string;
  interest?: string;
  lookingFor?: string;
  city: string;
  country: string;
  photos: Photo[];
}
