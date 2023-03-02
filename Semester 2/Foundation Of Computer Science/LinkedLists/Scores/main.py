class Score:
    """ Stores a player name and their score """

    def __init__(self, name, score):
        self.name = name
        self.score = score
        self.next: Score = None  # Next (lower) score
        self.prev: Score = None  # Previous (higher) score

    def __str__(self):
        return f"{self.name} : {self.score}"


class HighScores:
    """ Stores the top five high scores """

    # Initialise and manually set the capacity parameter to 5
    def __init__(self, capacity=5):
        """Initialise the class"""
        self._capacity = capacity
        self._no_scores = 0
        self.head: Score = None
        self.tail: Score = None

    def __str__(self):
        current = self.head
        output = []
        while current != None:
            output.append(str(current))
            current = current.next

        return "\n".join(output)

    def _node_to_replace(self, new_score: Score):
        """" Returns the node that
            the new score should replace, i.e. we should add the new score here and then link to this node"""
        cur_node = None
        i = 0
        while i < self._no_scores:
            if cur_node is None:
                cur_node = self.head
            else:
                cur_node = cur_node.next

            is_greater = cur_node.score < new_score.score
            is_prev_greater = (cur_node.prev is None) or (cur_node.prev.score > new_score.score)
            is_next_lower = (cur_node.next is None) or (cur_node.next.score < new_score.score)

            if is_greater and is_prev_greater and is_next_lower:
                return cur_node

            i += 1
        return None

    def _delete_last(self):
        """ Delete the last node. i.e replace the tail with the previous to last node"""
        self.tail.next = None

    def add_score(self, name, score):
        """Add a new Score object to the list,
            with the name and score parameters,
            if the list is not full or the score parameter is higher than the lowest stored score.
            The newly added Score object should be added at the right place to keep the list in order of score.
            """
        new_score = Score(name, score)
        if self._no_scores == 0:
            self.head = new_score
            self.tail = self.head
            self._no_scores += 1
            return

        if (new_score.score < self.tail.score) and (self._no_scores == self._capacity):
            return

        node_to_replace = self._node_to_replace(new_score)

        if node_to_replace is None:
            new_score.prev = self.tail
            self.tail.next = new_score
            self.tail = new_score

        elif node_to_replace == self.head:
            self.head = new_score
            self.head.next = node_to_replace
            node_to_replace.prev = new_score

        elif node_to_replace == self.tail:
            self.tail = new_score
            new_score.next = None
            self.tail.prev = node_to_replace
            node_to_replace.next = new_score

        else:
            new_score.next = node_to_replace
            if node_to_replace.prev is not None:
                new_score.prev = node_to_replace.prev
                node_to_replace.prev.next = new_score
            node_to_replace.prev = new_score

        if self._no_scores >= self._capacity:
            self.tail = self.tail.prev
            self._delete_last()
        else:
            self._no_scores += 1


if __name__ == "__main__":
    score_board = HighScores(capacity=5)
    score_board.add_score("Carolyn", 250)
    score_board.add_score("Martin", 199)

    print("+++ High Scores +++")
    print(score_board)  # Order: Carolyn, Martin
    print()

    score_board.add_score("Douglas", 251)
    score_board.add_score("Arthur", 28)
    score_board.add_score("Theresa", 233)

    print("+++ High Scores +++")
    print(score_board)  # Order: Douglas, Carolyn, Theresa, Martin, Arthur
    print()

    score_board.add_score("Herc", 120)

    print("+++ High Scores +++")
    print(score_board)  # Order: Douglas, Carolyn, Theresa, Martin, Herc
    print()

    score_board.add_score("Matt", 300)

    print("+++ High Scores +++")
    print(score_board)  # Order: Matt Douglas, Carolyn, Theresa, Martin
    print()

    hs = HighScores()

    hs.add_score("test 10", 10)
    hs.add_score("test 20", 20)
    hs.add_score("test 30", 30)
    hs.add_score("test 40", 40)
    hs.add_score("test 50", 50)
    hs.add_score("test 60", 60)
    hs.add_score("test 70", 70)
    print("+++ High Scores +++")
    print(hs)  # Order: test 70, test 60, test 50, test 40, test 30
    print()

    hs = HighScores(capacity=6)
    hs.add_score("test 10", 10)
    hs.add_score("test 20", 20)
    hs.add_score("test 30", 30)
    hs.add_score("test 40", 40)
    hs.add_score("test 50", 50)
    hs.add_score("test 60", 60)
    hs.add_score("test 70", 70)
    print("+++ High Scores +++")
    print(hs)  # Order: test 70, test 60, test 50, test 40, test 30, test 20
    print()

    hs = HighScores(capacity=2)

    hs.add_score("test 10", 10)
    hs.add_score("test 20", 20)
    hs.add_score("test 30", 30)
    hs.add_score("test 40", 40)
    hs.add_score("test 50", 50)
    hs.add_score("test 60", 60)
    hs.add_score("test 70", 70)
    print("+++ High Scores +++")
    print(hs)  # Order: test 70, test 60
