""" A playlist class, implementing a Linked List"""


class Song:
    """ Stores the title and artist for one song and a reference to the next song."""

    def __init__(self, songtitle, songartist):
        self.title = songtitle
        self.artist = songartist
        self.next = None

    def __str__(self):
        return f"{self.title} by {self.artist}"


class Playlist:
    "A playlist that implements a linked list"

    def __init__(self):
        self.head = None
        self.tail = None
        self._size = 0

    def size(self):
        return self._size

    def add_next(self, title, artist):
        """ Adds a new song as the first element in the list"""
        if self.head is None:
            self.head = Song(title, artist)
            self.tail = self.head

        else:
            next_node = self.head
            self.head = Song(title, artist)

            self.head.next = next_node

        self._size += 1

    def play_next(self):
        """ 'Plays' the next song (removing it from the list) """
        if self.head is None:
            return
        played_song = self.head
        self.head = self.head.next

        if self.head is None:
            self.tail = None
        self._size -= 1

        return str(played_song)

    def add_song(self, title, artist):
        """Add a song to the end of the playlist"""
        if self.head is None:
            self.head = Song(title, artist)
            self.tail = self.head
        else:
            prev_node = self.tail
            self.tail = Song(title, artist)

            prev_node.next = self.tail
        self._size += 1

    def add_song_at(self, title, artist, index):
        """ Adds a song at the given index """
        i = 0
        cur_node = None

        if index == 0:
            self.add_next(title, artist)
            return

        if index == self.size():
            self.add_last(title, artist)
            return

        while i < index:
            if cur_node == None:
                cur_node = self.head
            elif cur_node.next != None:
                cur_node = cur_node.next
            i += 1
        next_node = cur_node.next
        new_node = Song(title, artist)

        cur_node.next = new_node
        new_node.next = next_node

        self._size += 1

    def clear_playlist(self):
        """ Clears the entire playlist """
        self.head = None
        self.tail = None
        self._size = 0

    def __str__(self):

        current_node = self.head

        if current_node is None:
            return "+++ Playlist +++\nEmpty Playlist\n"

        i = 0
        output = ["+++ Playlist +++"]
        while current_node != None:
            if i == 0:
                output.append(f"Next:\t{current_node}")
            else:
                output.append(f"{i}:\t\t{current_node}")
            i += 1
            current_node = current_node.next
        output.append("\n")
        return "\n".join(output)


def menu(playlist):
    """ The main menu. This will use the Playlist class to simulate a simple Music Player"""
    print(playlist)
    print()
    print("+++ Main Menu +++")
    print("(1) Play Next")
    print("(2) Add Song")
    print("(3) Add Next Song")
    print("(4) Add Song at Position")
    print("(5) Clear Playlist")
    print("(Q) Quit")

    user_input = input("Please select an option... ")
    acceptable_input = ["1", "2", "3", "4", "5", "Q"]
    if user_input in acceptable_input:
        if user_input == "1":
            print(f"+++ Now Playing: {playlist.play_next()} +++")
            menu(playlist)
        elif user_input == "2":
            title = input("Please input song title ")
            artist = input("Please input song artist ")
            playlist.add_song(title, artist)
            menu(playlist)
        elif user_input == "3":
            title = input("Please input song title ")
            artist = input("Please input song artist ")
            playlist.add_next(title, artist)
            menu(playlist)
        elif user_input == "4":
            title = input("Please input song title ")
            artist = input("Please input song artist ")
            pos = input("Please input new song position")
            playlist.add_song_at(title, artist, pos)
            menu(playlist)

        elif user_input == "5":
            playlist.clear_playlist()
            menu(playlist)
        elif user_input == "Q":
            print("Bye!")

    else:
        print("Please type either 1, 2, 3, 4, or Q and then press enter.")
        menu(playlist)


# entry point of the program
if __name__ == "__main__":
    playlist = Playlist()
    playlist.add_song("Helterskelter", "The Beatles")
    print(playlist)
    # +++ Playlist +++
    # Next:   Helterskelter by The Beatles

    playlist.add_next("Battle of Evermore", "Led Zeppelin")
    print(playlist)
    # +++ Playlist +++
    # Next:   Battle of Evermore by Led Zeppelin
    # 1:      Helterskelter by The Beatles

    playlist.add_song("By the Way", "Red Hot Chili Peppers")
    print(playlist)
    # +++ Playlist +++
    # Next:   Battle of Evermore by Led Zeppelin
    # 1:      Helterskelter by The Beatles
    # 2:      By the Way by Red Hot Chili Peppers

    playlist.add_song_at("Bat Out of Hell", "Meatloaf", 1)
    print(playlist)
    # +++ Playlist +++
    # Next:   Battle of Evermore by Led Zeppelin
    # 1:      Bat Out of Hell by Meatloaf
    # 2:      Helterskelter by The Beatles
    # 3:      By the Way by Red Hot Chili Peppers

    playlist.clear_playlist()
    print(playlist)
    # +++ Playlist +++
    # Empty Playlist

    # menu(playlist)    # call main program, uncomment this line if you want to see the whole music player simulation