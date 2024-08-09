using System;
using System.Collections.Generic;

class Solution {
        public struct Pos
 {
     public int x; public int y;
 }

 public int FindPath(int[,] maps, Pos player, Pos enemy)
 {
     Queue<Pos> path = new Queue<Pos>();
     path.Enqueue(player);
     Pos[,] parent = new Pos[maps.GetLength(0), maps.GetLength(1)];
     bool[,] visited = new bool[maps.GetLength(0), maps.GetLength(1)];

     while (path.Count > 0)
     {
         Pos pos = path.Dequeue();

         // 오른쪽 가능
         if ((pos.x >= 0 && pos.x < maps.GetLength(1) - 1) &&
             maps[pos.y, pos.x + 1] == 1 && 
             visited[pos.y, pos.x + 1] != true )
         {
             Pos newPos = new Pos() { x = pos.x + 1, y = pos.y };
             path.Enqueue(newPos);
             parent[newPos.y, newPos.x] = pos;
             visited[newPos.y, newPos.x] = true;
         }
         // 아래 가능
         if ((pos.y >= 0 && pos.y < maps.GetLength(0) - 1) &&
             maps[pos.y + 1, pos.x ] == 1 &&
             visited[pos.y + 1, pos.x] != true)
         {
             Pos newPos = new Pos() { x = pos.x, y = pos.y + 1 };
             path.Enqueue(newPos);
             parent[newPos.y, newPos.x] = pos;
             visited[newPos.y, newPos.x] = true;
         }
         // 위로 가능
         if ((pos.y > 0 && pos.y <= maps.GetLength(0) - 1) &&
             maps[pos.y - 1, pos.x] == 1 &&
             visited[pos.y - 1, pos.x] != true)
         {
             Pos newPos = new Pos() { x = pos.x, y = pos.y - 1 };
             path.Enqueue(newPos);
             parent[newPos.y, newPos.x] = pos;
             visited[newPos.y, newPos.x] = true;
         }
         // 뒤로 가능
         if ((pos.x > 0 && pos.x <= maps.GetLength(1) - 1) &&
             maps[pos.y, pos.x - 1] == 1 &&
             visited[pos.y, pos.x - 1] != true)
         {
             Pos newPos = new Pos() { x = pos.x - 1, y = pos.y };
             path.Enqueue(newPos);
             parent[newPos.y, newPos.x] = pos;
             visited[newPos.y, newPos.x] = true;
         }

     }

     if (visited[enemy.y, enemy.x] == false) return -1;
     else
     {
         int count = 2;
         Pos pos = parent[enemy.y ,enemy.x];
         while(!pos.Equals(player))
         {
             pos = parent[pos.y, pos.x];
             count++;
         }
         return count;
     }
     
 }

 public int solution(int[,] maps)
 {
     int answer = 1;
     Pos player = new Pos() { x = 0, y = 0 };
     Pos enemy = new Pos() { x = maps.GetLength(1) - 1, y = maps.GetLength(0) - 1 };

     answer = FindPath(maps, player, enemy);

     return answer;
 }
}
