import { Photo } from "./photo";

export interface Member {
  id: number;
  userName: string;
  photoUrl: string;
  age: number;
  dateOfBirth: Date;
  lastActive: Date;
  gender: string;
  introduction: string;
  interest?: string;
  city: string;
  country: string;
  photos: Photo[];
}
